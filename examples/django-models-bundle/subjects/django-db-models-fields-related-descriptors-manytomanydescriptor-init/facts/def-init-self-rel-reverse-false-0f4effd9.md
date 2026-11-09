# Fact 0f4effd9

Store id: 75651042-4612-4c67-9608-0432580a2208

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
- posted_at: `2026-11-09T22:39:44.8414650+00:00`

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
  "id": "75651042-4612-4c67-9608-0432580a2208",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:44.8414650+00:00"
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
  "subject_id": "a4c8dcda-ea2e-4e1f-b487-cbf43773983f",
  "subject_name": "django/db/models/fields/related_descriptors::ManyToManyDescriptor.__init__",
  "tags": [
    "entity:method"
  ],
  "text": "def __init__(self, rel, reverse=False)"
}
```
