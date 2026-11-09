# Fact a0baa044

Store id: c2e4be26-17a0-44ab-bfd4-3da594afc223

## Text

```text
def CASCADE(collector, field, sub_objs, using)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:function`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T23:31:55.0255240+00:00`

## Data

```json
{
  "end_line": 31,
  "entity_kind": "function",
  "parent": "deletion",
  "start_line": 22,
  "symbol": "CASCADE"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/deletion.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":22,"selector":"L22-L31","symbol":"CASCADE"}`

## Referenced by

None.

## Subject

[django/db/models/deletion::CASCADE](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 31,
    "entity_kind": "function",
    "parent": "deletion",
    "start_line": 22,
    "symbol": "CASCADE"
  },
  "id": "c2e4be26-17a0-44ab-bfd4-3da594afc223",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:55.0255240+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 22,
        "selector": "L22-L31",
        "symbol": "CASCADE"
      },
      "rel": "derived_from",
      "target": "django/db/models/deletion.py"
    }
  ],
  "status": "live",
  "subject_id": "a863d2c8-c887-4375-b59c-472b35da8864",
  "subject_name": "django/db/models/deletion::CASCADE",
  "tags": [
    "entity:function"
  ],
  "text": "def CASCADE(collector, field, sub_objs, using)"
}
```
