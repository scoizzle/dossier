# Fact e2012c35

Store id: a5cdf02d-8998-47ab-a337-3effae7430cd

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
- posted_at: `2026-11-09T22:39:40.3315580+00:00`

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
  "id": "a5cdf02d-8998-47ab-a337-3effae7430cd",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:40.3315580+00:00"
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
  "subject_id": "466f5e0f-55b3-430f-a88e-f92caeea2e86",
  "subject_name": "django/db/models/base::Model.__init__",
  "tags": [
    "entity:method"
  ],
  "text": "def __init__(self, *args, **kwargs)"
}
```
