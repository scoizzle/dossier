# Fact e8e8d849

Store id: ea383178-0f06-493e-b2b0-fdc95f2b9220

## Text

```text
class UUIDContains(UUIDTextMixin, Contains)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:class`, `decorator:UUIDField.register_lookup`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T22:39:48.2810670+00:00`

## Data

```json
{
  "end_line": 807,
  "entity_kind": "class",
  "parent": "lookups",
  "start_line": 805,
  "symbol": "UUIDContains"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/lookups.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":805,"selector":"L805-L807","symbol":"UUIDContains"}`

## Referenced by

None.

## Subject

[django/db/models/lookups::UUIDContains](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 807,
    "entity_kind": "class",
    "parent": "lookups",
    "start_line": 805,
    "symbol": "UUIDContains"
  },
  "id": "ea383178-0f06-493e-b2b0-fdc95f2b9220",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:48.2810670+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 805,
        "selector": "L805-L807",
        "symbol": "UUIDContains"
      },
      "rel": "derived_from",
      "target": "django/db/models/lookups.py"
    }
  ],
  "status": "live",
  "subject_id": "54d49c6f-bd72-4cee-8e04-e3befc5ba492",
  "subject_name": "django/db/models/lookups::UUIDContains",
  "tags": [
    "entity:class",
    "decorator:UUIDField.register_lookup"
  ],
  "text": "class UUIDContains(UUIDTextMixin, Contains)"
}
```
