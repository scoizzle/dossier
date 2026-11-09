# Fact e8e8d849

Store id: 8026897a-3bb2-4171-a940-9eb2cd84fc57

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
- posted_at: `2026-11-09T23:32:03.4755610+00:00`

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
  "id": "8026897a-3bb2-4171-a940-9eb2cd84fc57",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:03.4755610+00:00"
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
  "subject_id": "55c0859e-f5c5-41f6-8901-83c763ca77b4",
  "subject_name": "django/db/models/lookups::UUIDContains",
  "tags": [
    "entity:class",
    "decorator:UUIDField.register_lookup"
  ],
  "text": "class UUIDContains(UUIDTextMixin, Contains)"
}
```
