# Fact 27ce8695

Store id: 5ba020ae-dc5c-4494-85b1-db4b9bf4810e

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
- posted_at: `2026-11-09T23:44:51.8609790+00:00`

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
  "id": "5ba020ae-dc5c-4494-85b1-db4b9bf4810e",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:51.8609790+00:00"
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
  "subject_id": "4c4539a6-2186-4f18-b952-805ebf41c443",
  "subject_name": "django/db/models/fields/related_descriptors::ForwardOneToOneDescriptor.get_object",
  "tags": [
    "entity:method"
  ],
  "text": "def get_object(self, instance)"
}
```
