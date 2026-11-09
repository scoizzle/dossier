# Fact 3edd4028

Store id: 0d791dd6-d5c3-4f4f-8ff0-15af4dbfeae6

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
- posted_at: `2026-11-09T23:44:51.8979560+00:00`

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
  "id": "0d791dd6-d5c3-4f4f-8ff0-15af4dbfeae6",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:51.8979560+00:00"
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
  "subject_id": "dc9e24e4-c879-40ec-8ac3-d2f28e71d6ce",
  "subject_name": "django/db/models/fields/related_descriptors::ReverseManyToOneDescriptor.__set__",
  "tags": [
    "entity:method"
  ],
  "text": "def __set__(self, instance, value)"
}
```
