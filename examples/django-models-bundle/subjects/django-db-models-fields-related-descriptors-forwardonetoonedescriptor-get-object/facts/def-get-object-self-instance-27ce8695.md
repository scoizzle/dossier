# Fact 27ce8695

Store id: d35d56d0-7adc-4a95-845f-63f9ce7150f9

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
- posted_at: `2026-11-09T22:39:44.7349710+00:00`

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
  "id": "d35d56d0-7adc-4a95-845f-63f9ce7150f9",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:44.7349710+00:00"
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
  "subject_id": "90973ef9-7a95-460e-8c0b-6ad839c8a1e2",
  "subject_name": "django/db/models/fields/related_descriptors::ForwardOneToOneDescriptor.get_object",
  "tags": [
    "entity:method"
  ],
  "text": "def get_object(self, instance)"
}
```
