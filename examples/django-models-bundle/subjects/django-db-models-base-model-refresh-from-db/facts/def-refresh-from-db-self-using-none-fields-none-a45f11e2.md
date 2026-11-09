# Fact a45f11e2

Store id: 7f13fc04-b6dd-4ffc-b726-b1fa34b02937

## Text

```text
def refresh_from_db(self, using=None, fields=None, from_queryset=None)
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
- posted_at: `2026-11-09T22:39:40.3370000+00:00`

## Data

```json
{
  "end_line": 817,
  "entity_kind": "method",
  "parent": "Model",
  "start_line": 735,
  "symbol": "Model.refresh_from_db"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/base.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":735,"selector":"L735-L817","symbol":"Model.refresh_from_db"}`

## Items

```json
[
  {
    "text": "Reload field values from the database.",
    "locator": {
      "line": 736
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/base::Model.refresh_from_db](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 817,
    "entity_kind": "method",
    "parent": "Model",
    "start_line": 735,
    "symbol": "Model.refresh_from_db"
  },
  "id": "7f13fc04-b6dd-4ffc-b726-b1fa34b02937",
  "items": [
    {
      "locator": {
        "line": 736
      },
      "text": "Reload field values from the database."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:40.3370000+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 735,
        "selector": "L735-L817",
        "symbol": "Model.refresh_from_db"
      },
      "rel": "derived_from",
      "target": "django/db/models/base.py"
    }
  ],
  "status": "live",
  "subject_id": "12a42b83-fd41-4970-b794-ec28fedf8d61",
  "subject_name": "django/db/models/base::Model.refresh_from_db",
  "tags": [
    "entity:method"
  ],
  "text": "def refresh_from_db(self, using=None, fields=None, from_queryset=None)"
}
```
