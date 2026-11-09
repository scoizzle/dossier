# Fact 27ce8695

Store id: 39a72082-5a24-4650-a1d7-a93bd2992987

## Text

```text
def get_object(self, instance)
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
- posted_at: `2026-11-09T23:31:59.1739280+00:00`

## Data

```json
{
  "end_line": 410,
  "entity_kind": "method",
  "parent": "ForwardOneToOneDescriptor",
  "start_line": 392,
  "symbol": "ForwardOneToOneDescriptor.get_object"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/related_descriptors.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":392,"selector":"L392-L410","symbol":"ForwardOneToOneDescriptor.get_object"}`

## Referenced by

None.

## Subject

[django/db/models/fields/related_descriptors::ForwardOneToOneDescriptor.get_object](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 410,
    "entity_kind": "method",
    "parent": "ForwardOneToOneDescriptor",
    "start_line": 392,
    "symbol": "ForwardOneToOneDescriptor.get_object"
  },
  "id": "39a72082-5a24-4650-a1d7-a93bd2992987",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:59.1739280+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 392,
        "selector": "L392-L410",
        "symbol": "ForwardOneToOneDescriptor.get_object"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/related_descriptors.py"
    }
  ],
  "status": "live",
  "subject_id": "e28e221d-1afd-4051-b1f4-5061d6144727",
  "subject_name": "django/db/models/fields/related_descriptors::ForwardOneToOneDescriptor.get_object",
  "tags": [
    "entity:method"
  ],
  "text": "def get_object(self, instance)"
}
```
