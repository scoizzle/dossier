# Fact 6e9cb35b

Store id: 593638fa-4a91-407d-a806-8f3fa1d0cd02

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
- posted_at: `2026-11-09T23:44:56.6560780+00:00`

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
  "id": "593638fa-4a91-407d-a806-8f3fa1d0cd02",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:56.6560780+00:00"
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
  "subject_id": "60ddf1f3-fc66-4696-8791-16248cd26cb5",
  "subject_name": "django/db/models/query_utils::RegisterLookupMixin",
  "tags": [
    "entity:class"
  ],
  "text": "class RegisterLookupMixin"
}
```
