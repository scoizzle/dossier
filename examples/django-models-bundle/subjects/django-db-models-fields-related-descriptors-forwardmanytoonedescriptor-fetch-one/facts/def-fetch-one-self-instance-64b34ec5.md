# Fact 64b34ec5

Store id: e648ce01-3ef9-4c75-b185-3fbd4204983c

## Text

```text
def fetch_one(self, instance)
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
- posted_at: `2026-11-09T23:31:59.1592980+00:00`

## Data

```json
{
  "end_line": 287,
  "entity_kind": "method",
  "parent": "ForwardManyToOneDescriptor",
  "start_line": 279,
  "symbol": "ForwardManyToOneDescriptor.fetch_one"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/related_descriptors.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":279,"selector":"L279-L287","symbol":"ForwardManyToOneDescriptor.fetch_one"}`

## Referenced by

None.

## Subject

[django/db/models/fields/related_descriptors::ForwardManyToOneDescriptor.fetch_one](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 287,
    "entity_kind": "method",
    "parent": "ForwardManyToOneDescriptor",
    "start_line": 279,
    "symbol": "ForwardManyToOneDescriptor.fetch_one"
  },
  "id": "e648ce01-3ef9-4c75-b185-3fbd4204983c",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:59.1592980+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 279,
        "selector": "L279-L287",
        "symbol": "ForwardManyToOneDescriptor.fetch_one"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/related_descriptors.py"
    }
  ],
  "status": "live",
  "subject_id": "7108e254-e41c-49d7-83d9-09c54d902191",
  "subject_name": "django/db/models/fields/related_descriptors::ForwardManyToOneDescriptor.fetch_one",
  "tags": [
    "entity:method"
  ],
  "text": "def fetch_one(self, instance)"
}
```
