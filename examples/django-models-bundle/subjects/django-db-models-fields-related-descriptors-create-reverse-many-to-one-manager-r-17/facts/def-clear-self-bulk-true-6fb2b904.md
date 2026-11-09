# Fact 6fb2b904

Store id: 630bf915-b97a-49d2-b242-0b43abdbb567

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
- posted_at: `2026-11-09T23:31:59.2856580+00:00`

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
  "id": "630bf915-b97a-49d2-b242-0b43abdbb567",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:59.2856580+00:00"
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
  "subject_id": "91329091-30fb-4269-a31d-db4634f6fb25",
  "subject_name": "django/db/models/fields/related_descriptors::create_reverse_many_to_one_manager.RelatedManager.clear",
  "tags": [
    "entity:method"
  ],
  "text": "def clear(self, *, bulk=True)"
}
```
