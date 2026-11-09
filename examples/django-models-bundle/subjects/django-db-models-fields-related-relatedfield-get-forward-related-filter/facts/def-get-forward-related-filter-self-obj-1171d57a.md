# Fact 1171d57a

Store id: 34defd8d-d5ac-4bc4-b86c-5e9931d4027f

## Text

```text
def get_forward_related_filter(self, obj)
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
- posted_at: `2026-11-09T23:44:51.4840990+00:00`

## Data

```json
{
  "end_line": 430,
  "entity_kind": "method",
  "parent": "RelatedField",
  "start_line": 419,
  "symbol": "RelatedField.get_forward_related_filter"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/related.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":419,"selector":"L419-L430","symbol":"RelatedField.get_forward_related_filter"}`

## Items

```json
[
  {
    "text": "Return the keyword arguments that when supplied to self.model.object.filter(), would select all instances related through this field to the remote obj. This is used to build the querysets returned by related descriptors. obj is an instance of self.related_field.model.",
    "locator": {
      "line": 420
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/fields/related::RelatedField.get_forward_related_filter](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 430,
    "entity_kind": "method",
    "parent": "RelatedField",
    "start_line": 419,
    "symbol": "RelatedField.get_forward_related_filter"
  },
  "id": "34defd8d-d5ac-4bc4-b86c-5e9931d4027f",
  "items": [
    {
      "locator": {
        "line": 420
      },
      "text": "Return the keyword arguments that when supplied to self.model.object.filter(), would select all instances related through this field to the remote obj. This is used to build the querysets returned by related descriptors. obj is an instance of self.related_field.model."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:51.4840990+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 419,
        "selector": "L419-L430",
        "symbol": "RelatedField.get_forward_related_filter"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/related.py"
    }
  ],
  "status": "live",
  "subject_id": "528a6378-2b1e-4855-9c6f-4c230d323563",
  "subject_name": "django/db/models/fields/related::RelatedField.get_forward_related_filter",
  "tags": [
    "entity:method"
  ],
  "text": "def get_forward_related_filter(self, obj)"
}
```
