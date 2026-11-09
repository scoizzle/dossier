# Fact a98651e3

Store id: 9ec12e84-9ab6-4ac0-babf-ccf6dd458e68

## Text

```text
def __set__(self, instance, value)
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
- posted_at: `2026-11-09T22:39:44.7370950+00:00`

## Data

```json
{
  "end_line": 429,
  "entity_kind": "method",
  "parent": "ForwardOneToOneDescriptor",
  "start_line": 412,
  "symbol": "ForwardOneToOneDescriptor.__set__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/related_descriptors.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":412,"selector":"L412-L429","symbol":"ForwardOneToOneDescriptor.__set__"}`

## Referenced by

None.

## Subject

[django/db/models/fields/related_descriptors::ForwardOneToOneDescriptor.__set__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 429,
    "entity_kind": "method",
    "parent": "ForwardOneToOneDescriptor",
    "start_line": 412,
    "symbol": "ForwardOneToOneDescriptor.__set__"
  },
  "id": "9ec12e84-9ab6-4ac0-babf-ccf6dd458e68",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:44.7370950+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 412,
        "selector": "L412-L429",
        "symbol": "ForwardOneToOneDescriptor.__set__"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/related_descriptors.py"
    }
  ],
  "status": "live",
  "subject_id": "bdf68770-8e35-498b-91eb-8dc9f978600b",
  "subject_name": "django/db/models/fields/related_descriptors::ForwardOneToOneDescriptor.__set__",
  "tags": [
    "entity:method"
  ],
  "text": "def __set__(self, instance, value)"
}
```
