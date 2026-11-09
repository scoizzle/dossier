# Fact 3edd4028

Store id: a474e1ed-c784-45f3-bfdf-db434d6ffd6d

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
- posted_at: `2026-11-09T23:31:59.2273310+00:00`

## Data

```json
{
  "end_line": 711,
  "entity_kind": "method",
  "parent": "ReverseManyToOneDescriptor",
  "start_line": 707,
  "symbol": "ReverseManyToOneDescriptor.__set__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/related_descriptors.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":707,"selector":"L707-L711","symbol":"ReverseManyToOneDescriptor.__set__"}`

## Referenced by

None.

## Subject

[django/db/models/fields/related_descriptors::ReverseManyToOneDescriptor.__set__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 711,
    "entity_kind": "method",
    "parent": "ReverseManyToOneDescriptor",
    "start_line": 707,
    "symbol": "ReverseManyToOneDescriptor.__set__"
  },
  "id": "a474e1ed-c784-45f3-bfdf-db434d6ffd6d",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:59.2273310+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 707,
        "selector": "L707-L711",
        "symbol": "ReverseManyToOneDescriptor.__set__"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/related_descriptors.py"
    }
  ],
  "status": "live",
  "subject_id": "ccb4d952-9ae3-4146-bebc-a671ce1f14f5",
  "subject_name": "django/db/models/fields/related_descriptors::ReverseManyToOneDescriptor.__set__",
  "tags": [
    "entity:method"
  ],
  "text": "def __set__(self, instance, value)"
}
```
