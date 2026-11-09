# Fact 1c2d2674

Store id: 75c616cd-3ce5-4e61-959e-e410dc678af3

## Text

```text
def allowed_default(self)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:method`, `decorator:cached_property`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T23:31:55.9659180+00:00`

## Data

```json
{
  "end_line": 1813,
  "entity_kind": "method",
  "parent": "Case",
  "start_line": 1809,
  "symbol": "Case.allowed_default"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1809,"selector":"L1809-L1813","symbol":"Case.allowed_default"}`

## Referenced by

None.

## Subject

[django/db/models/expressions::Case.allowed_default](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1813,
    "entity_kind": "method",
    "parent": "Case",
    "start_line": 1809,
    "symbol": "Case.allowed_default"
  },
  "id": "75c616cd-3ce5-4e61-959e-e410dc678af3",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:55.9659180+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1809,
        "selector": "L1809-L1813",
        "symbol": "Case.allowed_default"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "3ddfc13f-1d59-4a4f-be12-eb87840412c9",
  "subject_name": "django/db/models/expressions::Case.allowed_default",
  "tags": [
    "entity:method",
    "decorator:cached_property"
  ],
  "text": "def allowed_default(self)"
}
```
