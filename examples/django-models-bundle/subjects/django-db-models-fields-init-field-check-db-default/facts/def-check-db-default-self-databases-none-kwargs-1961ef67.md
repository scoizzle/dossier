# Fact 1961ef67

Store id: 8a5a5830-1ebb-4c19-b932-4977fdd5bfd2

## Text

```text
def _check_db_default(self, databases=None, **kwargs)
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
- posted_at: `2026-11-09T23:44:49.9742850+00:00`

## Data

```json
{
  "end_line": 459,
  "entity_kind": "method",
  "parent": "Field",
  "start_line": 425,
  "symbol": "Field._check_db_default"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":425,"selector":"L425-L459","symbol":"Field._check_db_default"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::Field._check_db_default](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 459,
    "entity_kind": "method",
    "parent": "Field",
    "start_line": 425,
    "symbol": "Field._check_db_default"
  },
  "id": "8a5a5830-1ebb-4c19-b932-4977fdd5bfd2",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:49.9742850+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 425,
        "selector": "L425-L459",
        "symbol": "Field._check_db_default"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "3fde24dc-921f-4b19-b09b-91eff7d6c50b",
  "subject_name": "django/db/models/fields/__init__::Field._check_db_default",
  "tags": [
    "entity:method"
  ],
  "text": "def _check_db_default(self, databases=None, **kwargs)"
}
```
