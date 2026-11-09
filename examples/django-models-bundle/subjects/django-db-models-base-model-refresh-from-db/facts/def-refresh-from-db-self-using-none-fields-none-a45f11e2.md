# Fact a45f11e2

Store id: 35f23127-8437-426b-a089-c780a390691d

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
- posted_at: `2026-11-09T23:31:53.7384820+00:00`

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
  "id": "35f23127-8437-426b-a089-c780a390691d",
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
    "posted_at": "2026-11-09T23:31:53.7384820+00:00"
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
  "subject_id": "52514a79-95d3-4e99-8d85-933f9a732b84",
  "subject_name": "django/db/models/base::Model.refresh_from_db",
  "tags": [
    "entity:method"
  ],
  "text": "def refresh_from_db(self, using=None, fields=None, from_queryset=None)"
}
```
