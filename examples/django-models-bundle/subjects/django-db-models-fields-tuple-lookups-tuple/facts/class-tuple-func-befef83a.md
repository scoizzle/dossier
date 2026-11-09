# Fact befef83a

Store id: ed417a3d-4a6a-4800-a368-edcbbec4cdcb

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
- posted_at: `2026-11-09T23:44:52.6650220+00:00`

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
  "id": "ed417a3d-4a6a-4800-a368-edcbbec4cdcb",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:52.6650220+00:00"
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
  "subject_id": "e21f25c4-1113-49e9-a60a-b312d4f64d5f",
  "subject_name": "django/db/models/fields/tuple_lookups::Tuple",
  "tags": [
    "entity:class"
  ],
  "text": "class Tuple(Func)"
}
```
