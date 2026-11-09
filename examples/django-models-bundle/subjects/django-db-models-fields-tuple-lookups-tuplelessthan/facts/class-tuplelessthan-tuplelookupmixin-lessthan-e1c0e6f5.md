# Fact e1c0e6f5

Store id: 5e446099-9851-4626-b1b7-a085fe9d4130

## Text

```text
class TupleLessThan(TupleLookupMixin, LessThan)
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
- posted_at: `2026-11-09T23:32:00.6085790+00:00`

## Data

```json
{
  "end_line": 272,
  "entity_kind": "class",
  "parent": "tuple_lookups",
  "start_line": 247,
  "symbol": "TupleLessThan"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/tuple_lookups.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":247,"selector":"L247-L272","symbol":"TupleLessThan"}`

## Referenced by

None.

## Subject

[django/db/models/fields/tuple_lookups::TupleLessThan](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 272,
    "entity_kind": "class",
    "parent": "tuple_lookups",
    "start_line": 247,
    "symbol": "TupleLessThan"
  },
  "id": "5e446099-9851-4626-b1b7-a085fe9d4130",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:00.6085790+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 247,
        "selector": "L247-L272",
        "symbol": "TupleLessThan"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/tuple_lookups.py"
    }
  ],
  "status": "live",
  "subject_id": "6dd8028d-0254-4828-b1cb-b1761fc099b3",
  "subject_name": "django/db/models/fields/tuple_lookups::TupleLessThan",
  "tags": [
    "entity:class"
  ],
  "text": "class TupleLessThan(TupleLookupMixin, LessThan)"
}
```
