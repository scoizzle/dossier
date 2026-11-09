# Fact 886b048a

Store id: cbec2d06-804a-4b13-bf5b-4376a0707e73

## Text

```text
class IntegerFieldExact(IntegerFieldOverflow, Exact)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:class`, `decorator:IntegerField.register_lookup`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T23:32:03.3009130+00:00`

## Data

```json
{
  "end_line": 477,
  "entity_kind": "class",
  "parent": "lookups",
  "start_line": 475,
  "symbol": "IntegerFieldExact"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/lookups.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":475,"selector":"L475-L477","symbol":"IntegerFieldExact"}`

## Referenced by

None.

## Subject

[django/db/models/lookups::IntegerFieldExact](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 477,
    "entity_kind": "class",
    "parent": "lookups",
    "start_line": 475,
    "symbol": "IntegerFieldExact"
  },
  "id": "cbec2d06-804a-4b13-bf5b-4376a0707e73",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:03.3009130+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 475,
        "selector": "L475-L477",
        "symbol": "IntegerFieldExact"
      },
      "rel": "derived_from",
      "target": "django/db/models/lookups.py"
    }
  ],
  "status": "live",
  "subject_id": "156c74bb-9f73-4f5c-b2b8-9a7e559361d3",
  "subject_name": "django/db/models/lookups::IntegerFieldExact",
  "tags": [
    "entity:class",
    "decorator:IntegerField.register_lookup"
  ],
  "text": "class IntegerFieldExact(IntegerFieldOverflow, Exact)"
}
```
