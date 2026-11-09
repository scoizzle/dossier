# Fact 91cbc438

Store id: 08d4172b-aa3a-4dd6-9cdc-4bbe8c43d635

## Text

```text
def __init__(self, num_buckets=1, **extra)
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
- posted_at: `2026-11-09T23:32:02.7276230+00:00`

## Data

```json
{
  "end_line": 102,
  "entity_kind": "method",
  "parent": "Ntile",
  "start_line": 99,
  "symbol": "Ntile.__init__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/functions/window.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":99,"selector":"L99-L102","symbol":"Ntile.__init__"}`

## Referenced by

None.

## Subject

[django/db/models/functions/window::Ntile.__init__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 102,
    "entity_kind": "method",
    "parent": "Ntile",
    "start_line": 99,
    "symbol": "Ntile.__init__"
  },
  "id": "08d4172b-aa3a-4dd6-9cdc-4bbe8c43d635",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:02.7276230+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 99,
        "selector": "L99-L102",
        "symbol": "Ntile.__init__"
      },
      "rel": "derived_from",
      "target": "django/db/models/functions/window.py"
    }
  ],
  "status": "live",
  "subject_id": "f560fb58-6ebc-4c18-9eb1-64432e9f41c5",
  "subject_name": "django/db/models/functions/window::Ntile.__init__",
  "tags": [
    "entity:method"
  ],
  "text": "def __init__(self, num_buckets=1, **extra)"
}
```
