# Fact 03c53741

Store id: 0111c510-b490-495c-b602-a66d0613c844

## Text

```text
def get_class_lookups(cls)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:method`, `decorator:functools.cache`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T23:32:05.1476100+00:00`

## Data

```json
{
  "end_line": 345,
  "entity_kind": "method",
  "parent": "RegisterLookupMixin",
  "start_line": 340,
  "symbol": "RegisterLookupMixin.get_class_lookups"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/query_utils.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":340,"selector":"L340-L345","symbol":"RegisterLookupMixin.get_class_lookups"}`

## Referenced by

None.

## Subject

[django/db/models/query_utils::RegisterLookupMixin.get_class_lookups](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 345,
    "entity_kind": "method",
    "parent": "RegisterLookupMixin",
    "start_line": 340,
    "symbol": "RegisterLookupMixin.get_class_lookups"
  },
  "id": "0111c510-b490-495c-b602-a66d0613c844",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:05.1476100+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 340,
        "selector": "L340-L345",
        "symbol": "RegisterLookupMixin.get_class_lookups"
      },
      "rel": "derived_from",
      "target": "django/db/models/query_utils.py"
    }
  ],
  "status": "live",
  "subject_id": "32238927-3d04-4540-b300-9353ad02b959",
  "subject_name": "django/db/models/query_utils::RegisterLookupMixin.get_class_lookups",
  "tags": [
    "entity:method",
    "decorator:functools.cache"
  ],
  "text": "def get_class_lookups(cls)"
}
```
