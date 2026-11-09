# Fact a45f11e2

Store id: 485fe2db-7587-4034-a7f2-4f538d5b3e1e

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
- posted_at: `2026-11-09T23:44:48.5316640+00:00`

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
  "id": "485fe2db-7587-4034-a7f2-4f538d5b3e1e",
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
    "posted_at": "2026-11-09T23:44:48.5316640+00:00"
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
  "subject_id": "d67fbf27-af0c-4814-9602-481c514e14df",
  "subject_name": "django/db/models/base::Model.refresh_from_db",
  "tags": [
    "entity:method"
  ],
  "text": "def refresh_from_db(self, using=None, fields=None, from_queryset=None)"
}
```
