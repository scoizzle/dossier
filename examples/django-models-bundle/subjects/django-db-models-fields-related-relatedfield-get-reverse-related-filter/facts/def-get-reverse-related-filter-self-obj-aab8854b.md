# Fact aab8854b

Store id: 53489046-b202-4d0f-9008-c1b169b6f31e

## Text

```text
def get_reverse_related_filter(self, obj)
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
- posted_at: `2026-11-09T22:39:44.2732620+00:00`

## Data

```json
{
  "end_line": 450,
  "entity_kind": "method",
  "parent": "RelatedField",
  "start_line": 432,
  "symbol": "RelatedField.get_reverse_related_filter"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/related.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":432,"selector":"L432-L450","symbol":"RelatedField.get_reverse_related_filter"}`

## Items

```json
[
  {
    "text": "Complement to get_forward_related_filter(). Return the keyword arguments that when passed to self.related_field.model.object.filter() select all instances of self.related_field.model related through this field to obj. obj is an instance of self.model.",
    "locator": {
      "line": 433
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/fields/related::RelatedField.get_reverse_related_filter](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 450,
    "entity_kind": "method",
    "parent": "RelatedField",
    "start_line": 432,
    "symbol": "RelatedField.get_reverse_related_filter"
  },
  "id": "53489046-b202-4d0f-9008-c1b169b6f31e",
  "items": [
    {
      "locator": {
        "line": 433
      },
      "text": "Complement to get_forward_related_filter(). Return the keyword arguments that when passed to self.related_field.model.object.filter() select all instances of self.related_field.model related through this field to obj. obj is an instance of self.model."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:44.2732620+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 432,
        "selector": "L432-L450",
        "symbol": "RelatedField.get_reverse_related_filter"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/related.py"
    }
  ],
  "status": "live",
  "subject_id": "d668c91d-ed02-4831-9ab8-01b588b82157",
  "subject_name": "django/db/models/fields/related::RelatedField.get_reverse_related_filter",
  "tags": [
    "entity:method"
  ],
  "text": "def get_reverse_related_filter(self, obj)"
}
```
