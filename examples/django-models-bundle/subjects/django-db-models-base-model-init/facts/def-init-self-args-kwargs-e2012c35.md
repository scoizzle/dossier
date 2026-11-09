# Fact e2012c35

Store id: fc33124c-360b-46cd-8f1d-e9745787c045

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
- posted_at: `2026-11-09T23:31:53.7318880+00:00`

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
  "id": "fc33124c-360b-46cd-8f1d-e9745787c045",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:53.7318880+00:00"
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
  "subject_id": "0a1277af-3a60-42d2-82ba-4b0434f125e3",
  "subject_name": "django/db/models/base::Model.__init__",
  "tags": [
    "entity:method"
  ],
  "text": "def __init__(self, *args, **kwargs)"
}
```
