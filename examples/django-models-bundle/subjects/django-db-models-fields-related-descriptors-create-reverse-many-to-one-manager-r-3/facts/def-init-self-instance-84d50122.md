# Fact 84d50122

Store id: b8d679d7-3dc1-4a9a-91ff-6cc82605014a

## Text

```text
def __init__(self, instance)
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
- posted_at: `2026-11-09T23:31:59.2335080+00:00`

## Data

```json
{
  "end_line": 730,
  "entity_kind": "method",
  "parent": "create_reverse_many_to_one_manager.RelatedManager",
  "start_line": 723,
  "symbol": "create_reverse_many_to_one_manager.RelatedManager.__init__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/related_descriptors.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":723,"selector":"L723-L730","symbol":"create_reverse_many_to_one_manager.RelatedManager.__init__"}`

## Referenced by

None.

## Subject

[django/db/models/fields/related_descriptors::create_reverse_many_to_one_manager.RelatedManager.__init__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 730,
    "entity_kind": "method",
    "parent": "create_reverse_many_to_one_manager.RelatedManager",
    "start_line": 723,
    "symbol": "create_reverse_many_to_one_manager.RelatedManager.__init__"
  },
  "id": "b8d679d7-3dc1-4a9a-91ff-6cc82605014a",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:59.2335080+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 723,
        "selector": "L723-L730",
        "symbol": "create_reverse_many_to_one_manager.RelatedManager.__init__"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/related_descriptors.py"
    }
  ],
  "status": "live",
  "subject_id": "0ece2831-bbdc-4e35-8336-7a9a38aae44a",
  "subject_name": "django/db/models/fields/related_descriptors::create_reverse_many_to_one_manager.RelatedManager.__init__",
  "tags": [
    "entity:method"
  ],
  "text": "def __init__(self, instance)"
}
```
