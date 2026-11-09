# Fact 00f09d0d

Store id: 63912f63-fd7b-4d9a-88e3-94067e9452d7

## Text

```text
def get_deferred_fields(self)
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
- posted_at: `2026-11-09T22:39:40.3365650+00:00`

## Data

```json
{
  "end_line": 733,
  "entity_kind": "method",
  "parent": "Model",
  "start_line": 725,
  "symbol": "Model.get_deferred_fields"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/base.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":725,"selector":"L725-L733","symbol":"Model.get_deferred_fields"}`

## Items

```json
[
  {
    "text": "Return a set containing names of deferred fields for this instance.",
    "locator": {
      "line": 726
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/base::Model.get_deferred_fields](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 733,
    "entity_kind": "method",
    "parent": "Model",
    "start_line": 725,
    "symbol": "Model.get_deferred_fields"
  },
  "id": "63912f63-fd7b-4d9a-88e3-94067e9452d7",
  "items": [
    {
      "locator": {
        "line": 726
      },
      "text": "Return a set containing names of deferred fields for this instance."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:40.3365650+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 725,
        "selector": "L725-L733",
        "symbol": "Model.get_deferred_fields"
      },
      "rel": "derived_from",
      "target": "django/db/models/base.py"
    }
  ],
  "status": "live",
  "subject_id": "549be597-7035-4898-af55-ca9606e8c647",
  "subject_name": "django/db/models/base::Model.get_deferred_fields",
  "tags": [
    "entity:method"
  ],
  "text": "def get_deferred_fields(self)"
}
```
