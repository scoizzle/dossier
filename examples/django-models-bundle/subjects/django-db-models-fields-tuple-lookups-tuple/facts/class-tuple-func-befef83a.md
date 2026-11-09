# Fact befef83a

Store id: b682f888-3126-4528-8b83-720547893b21

## Text

```text
class Tuple(Func)
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
- posted_at: `2026-11-09T23:32:00.5095060+00:00`

## Data

```json
{
  "end_line": 47,
  "entity_kind": "class",
  "parent": "tuple_lookups",
  "start_line": 27,
  "symbol": "Tuple"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/tuple_lookups.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":27,"selector":"L27-L47","symbol":"Tuple"}`

## Referenced by

None.

## Subject

[django/db/models/fields/tuple_lookups::Tuple](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 47,
    "entity_kind": "class",
    "parent": "tuple_lookups",
    "start_line": 27,
    "symbol": "Tuple"
  },
  "id": "b682f888-3126-4528-8b83-720547893b21",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:00.5095060+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 27,
        "selector": "L27-L47",
        "symbol": "Tuple"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/tuple_lookups.py"
    }
  ],
  "status": "live",
  "subject_id": "523631c0-929d-48aa-9285-912e9d4b584c",
  "subject_name": "django/db/models/fields/tuple_lookups::Tuple",
  "tags": [
    "entity:class"
  ],
  "text": "class Tuple(Func)"
}
```
