# Fact 900760ab

Store id: d4def1ad-c6df-41c7-a23e-8fb06758a23e

## Text

```text
def __copy__(self)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:method`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T22:39:42.3040720+00:00`

## Data

```json
{
  "end_line": 762,
  "entity_kind": "method",
  "parent": "Field",
  "start_line": 756,
  "symbol": "Field.__copy__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":756,"selector":"L756-L762","symbol":"Field.__copy__"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::Field.__copy__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 762,
    "entity_kind": "method",
    "parent": "Field",
    "start_line": 756,
    "symbol": "Field.__copy__"
  },
  "id": "d4def1ad-c6df-41c7-a23e-8fb06758a23e",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:42.3040720+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 756,
        "selector": "L756-L762",
        "symbol": "Field.__copy__"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "138fe21d-f87a-4740-a072-ddfd6372b5ae",
  "subject_name": "django/db/models/fields/__init__::Field.__copy__",
  "tags": [
    "entity:method"
  ],
  "text": "def __copy__(self)"
}
```
