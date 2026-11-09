# Fact 886b048a

Store id: c58da573-6f29-4311-8206-511ae6d654b9

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
- posted_at: `2026-11-09T23:44:54.9851710+00:00`

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
  "id": "c58da573-6f29-4311-8206-511ae6d654b9",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:54.9851710+00:00"
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
  "subject_id": "58e0e1d3-c800-4559-b00f-25e409cbbf99",
  "subject_name": "django/db/models/lookups::IntegerFieldExact",
  "tags": [
    "entity:class",
    "decorator:IntegerField.register_lookup"
  ],
  "text": "class IntegerFieldExact(IntegerFieldOverflow, Exact)"
}
```
