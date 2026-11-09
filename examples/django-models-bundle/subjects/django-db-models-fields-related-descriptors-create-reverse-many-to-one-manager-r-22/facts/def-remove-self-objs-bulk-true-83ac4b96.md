# Fact 83ac4b96

Store id: 0e6ac32f-8f14-433d-a463-4244c8ab1126

## Text

```text
def remove(self, *objs, bulk=True)
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
- posted_at: `2026-11-09T23:31:59.2758550+00:00`

## Data

```json
{
  "end_line": 957,
  "entity_kind": "method",
  "parent": "create_reverse_many_to_one_manager.RelatedManager",
  "start_line": 935,
  "symbol": "create_reverse_many_to_one_manager.RelatedManager.remove"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/related_descriptors.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":935,"selector":"L935-L957","symbol":"create_reverse_many_to_one_manager.RelatedManager.remove"}`

## Referenced by

None.

## Subject

[django/db/models/fields/related_descriptors::create_reverse_many_to_one_manager.RelatedManager.remove](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 957,
    "entity_kind": "method",
    "parent": "create_reverse_many_to_one_manager.RelatedManager",
    "start_line": 935,
    "symbol": "create_reverse_many_to_one_manager.RelatedManager.remove"
  },
  "id": "0e6ac32f-8f14-433d-a463-4244c8ab1126",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:59.2758550+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 935,
        "selector": "L935-L957",
        "symbol": "create_reverse_many_to_one_manager.RelatedManager.remove"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/related_descriptors.py"
    }
  ],
  "status": "live",
  "subject_id": "0a21d7e2-d1af-419a-88ef-67c245621677",
  "subject_name": "django/db/models/fields/related_descriptors::create_reverse_many_to_one_manager.RelatedManager.remove",
  "tags": [
    "entity:method"
  ],
  "text": "def remove(self, *objs, bulk=True)"
}
```
