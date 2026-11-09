# Fact 84d50122

Store id: 41bbb146-2e97-4468-8352-f2534e76dc1e

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
- posted_at: `2026-11-09T22:39:44.7880250+00:00`

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
  "id": "41bbb146-2e97-4468-8352-f2534e76dc1e",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:44.7880250+00:00"
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
  "subject_id": "fa074499-ff50-42ae-b349-c98ea956b543",
  "subject_name": "django/db/models/fields/related_descriptors::create_reverse_many_to_one_manager.RelatedManager.__init__",
  "tags": [
    "entity:method"
  ],
  "text": "def __init__(self, instance)"
}
```
