# Fact 0f4effd9

Store id: cb8ac2b2-fae6-4b53-b2af-487c97bdc740

## Text

```text
def __init__(self, rel, reverse=False)
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
- posted_at: `2026-11-09T23:44:51.9515080+00:00`

## Data

```json
{
  "end_line": 1048,
  "entity_kind": "method",
  "parent": "ManyToManyDescriptor",
  "start_line": 1045,
  "symbol": "ManyToManyDescriptor.__init__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/related_descriptors.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1045,"selector":"L1045-L1048","symbol":"ManyToManyDescriptor.__init__"}`

## Referenced by

None.

## Subject

[django/db/models/fields/related_descriptors::ManyToManyDescriptor.__init__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1048,
    "entity_kind": "method",
    "parent": "ManyToManyDescriptor",
    "start_line": 1045,
    "symbol": "ManyToManyDescriptor.__init__"
  },
  "id": "cb8ac2b2-fae6-4b53-b2af-487c97bdc740",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:51.9515080+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1045,
        "selector": "L1045-L1048",
        "symbol": "ManyToManyDescriptor.__init__"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/related_descriptors.py"
    }
  ],
  "status": "live",
  "subject_id": "b73fa989-37b7-4879-9c1a-6f6116d1b8f9",
  "subject_name": "django/db/models/fields/related_descriptors::ManyToManyDescriptor.__init__",
  "tags": [
    "entity:method"
  ],
  "text": "def __init__(self, rel, reverse=False)"
}
```
