# Fact eb741c4d

Store id: b4b396c2-6c1b-47d4-a5b6-6e8eb15badbd

## Text

```text
def remove(self, *objs)
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
- posted_at: `2026-11-09T23:31:59.4532100+00:00`

## Data

```json
{
  "end_line": 1346,
  "entity_kind": "method",
  "parent": "create_forward_many_to_many_manager.ManyRelatedManager",
  "start_line": 1343,
  "symbol": "create_forward_many_to_many_manager.ManyRelatedManager.remove"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/related_descriptors.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1343,"selector":"L1343-L1346","symbol":"create_forward_many_to_many_manager.ManyRelatedManager.remove"}`

## Referenced by

None.

## Subject

[django/db/models/fields/related_descriptors::create_forward_many_to_many_manager.ManyRelatedManager.remove](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1346,
    "entity_kind": "method",
    "parent": "create_forward_many_to_many_manager.ManyRelatedManager",
    "start_line": 1343,
    "symbol": "create_forward_many_to_many_manager.ManyRelatedManager.remove"
  },
  "id": "b4b396c2-6c1b-47d4-a5b6-6e8eb15badbd",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:59.4532100+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1343,
        "selector": "L1343-L1346",
        "symbol": "create_forward_many_to_many_manager.ManyRelatedManager.remove"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/related_descriptors.py"
    }
  ],
  "status": "live",
  "subject_id": "8c8deac4-7392-4928-aa96-fd8ff7ec2856",
  "subject_name": "django/db/models/fields/related_descriptors::create_forward_many_to_many_manager.ManyRelatedManager.remove",
  "tags": [
    "entity:method"
  ],
  "text": "def remove(self, *objs)"
}
```
