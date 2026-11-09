# Fact 6e9cb35b

Store id: d656e89a-5696-4df4-98cb-570bf42be2a8

## Text

```text
class RegisterLookupMixin
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:class`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T22:39:50.1364220+00:00`

## Data

```json
{
  "end_line": 437,
  "entity_kind": "class",
  "parent": "query_utils",
  "start_line": 336,
  "symbol": "RegisterLookupMixin"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/query_utils.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":336,"selector":"L336-L437","symbol":"RegisterLookupMixin"}`

## Referenced by

None.

## Subject

[django/db/models/query_utils::RegisterLookupMixin](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 437,
    "entity_kind": "class",
    "parent": "query_utils",
    "start_line": 336,
    "symbol": "RegisterLookupMixin"
  },
  "id": "d656e89a-5696-4df4-98cb-570bf42be2a8",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:50.1364220+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 336,
        "selector": "L336-L437",
        "symbol": "RegisterLookupMixin"
      },
      "rel": "derived_from",
      "target": "django/db/models/query_utils.py"
    }
  ],
  "status": "live",
  "subject_id": "d5edbdf5-61d0-46c9-8af9-d8c21923b662",
  "subject_name": "django/db/models/query_utils::RegisterLookupMixin",
  "tags": [
    "entity:class"
  ],
  "text": "class RegisterLookupMixin"
}
```
