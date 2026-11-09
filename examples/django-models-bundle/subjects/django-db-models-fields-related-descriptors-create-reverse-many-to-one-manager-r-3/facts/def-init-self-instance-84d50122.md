# Fact 84d50122

Store id: 5d0fbec3-5f81-4d3a-a075-d02e19dba8da

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
- posted_at: `2026-11-09T23:44:51.9035430+00:00`

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
  "id": "5d0fbec3-5f81-4d3a-a075-d02e19dba8da",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:51.9035430+00:00"
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
  "subject_id": "eea8fd03-dc3d-4abf-9529-6d9d533bcf2d",
  "subject_name": "django/db/models/fields/related_descriptors::create_reverse_many_to_one_manager.RelatedManager.__init__",
  "tags": [
    "entity:method"
  ],
  "text": "def __init__(self, instance)"
}
```
