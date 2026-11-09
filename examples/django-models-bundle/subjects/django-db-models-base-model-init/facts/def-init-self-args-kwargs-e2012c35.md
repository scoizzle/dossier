# Fact e2012c35

Store id: 7650f455-af04-4360-bba6-1a1152c69d88

## Text

```text
def __init__(self, *args, **kwargs)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:method`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T23:44:48.5258020+00:00`

## Data

```json
{
  "end_line": 615,
  "entity_kind": "method",
  "parent": "Model",
  "start_line": 502,
  "symbol": "Model.__init__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/base.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":502,"selector":"L502-L615","symbol":"Model.__init__"}`

## Referenced by

None.

## Subject

[django/db/models/base::Model.__init__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 615,
    "entity_kind": "method",
    "parent": "Model",
    "start_line": 502,
    "symbol": "Model.__init__"
  },
  "id": "7650f455-af04-4360-bba6-1a1152c69d88",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:48.5258020+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 502,
        "selector": "L502-L615",
        "symbol": "Model.__init__"
      },
      "rel": "derived_from",
      "target": "django/db/models/base.py"
    }
  ],
  "status": "live",
  "subject_id": "73b7f270-46eb-4d61-9f27-28f61df6b117",
  "subject_name": "django/db/models/base::Model.__init__",
  "tags": [
    "entity:method"
  ],
  "text": "def __init__(self, *args, **kwargs)"
}
```
