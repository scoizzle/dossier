# Fact 3edd4028

Store id: ac4b2d8e-8391-420c-bf80-687d4be87b91

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
- posted_at: `2026-11-09T22:39:44.7815410+00:00`

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
  "id": "ac4b2d8e-8391-420c-bf80-687d4be87b91",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:44.7815410+00:00"
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
  "subject_id": "e9a3854e-2d57-4cb7-a157-2061e5241883",
  "subject_name": "django/db/models/fields/related_descriptors::ReverseManyToOneDescriptor.__set__",
  "tags": [
    "entity:method"
  ],
  "text": "def __set__(self, instance, value)"
}
```
