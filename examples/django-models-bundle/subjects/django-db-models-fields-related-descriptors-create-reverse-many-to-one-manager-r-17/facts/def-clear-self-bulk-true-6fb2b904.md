# Fact 6fb2b904

Store id: 6b9c3d06-a052-487c-862d-a386b611b61a

## Text

```text
def clear(self, *, bulk=True)
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
- posted_at: `2026-11-09T23:44:51.9408330+00:00`

## Data

```json
{
  "end_line": 968,
  "entity_kind": "method",
  "parent": "create_reverse_many_to_one_manager.RelatedManager",
  "start_line": 966,
  "symbol": "create_reverse_many_to_one_manager.RelatedManager.clear"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/related_descriptors.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":966,"selector":"L966-L968","symbol":"create_reverse_many_to_one_manager.RelatedManager.clear"}`

## Referenced by

None.

## Subject

[django/db/models/fields/related_descriptors::create_reverse_many_to_one_manager.RelatedManager.clear](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 968,
    "entity_kind": "method",
    "parent": "create_reverse_many_to_one_manager.RelatedManager",
    "start_line": 966,
    "symbol": "create_reverse_many_to_one_manager.RelatedManager.clear"
  },
  "id": "6b9c3d06-a052-487c-862d-a386b611b61a",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:51.9408330+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 966,
        "selector": "L966-L968",
        "symbol": "create_reverse_many_to_one_manager.RelatedManager.clear"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/related_descriptors.py"
    }
  ],
  "status": "live",
  "subject_id": "731835ae-0b2f-4746-94f8-d980ed00e074",
  "subject_name": "django/db/models/fields/related_descriptors::create_reverse_many_to_one_manager.RelatedManager.clear",
  "tags": [
    "entity:method"
  ],
  "text": "def clear(self, *, bulk=True)"
}
```
