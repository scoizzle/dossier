# Fact a52f7dc5

Store id: 18363d27-8239-4845-81b5-10142bbf6468

## Text

```text
class ATan2(NumericOutputFieldMixin, Func)
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
- posted_at: `2026-11-09T23:32:01.6724110+00:00`

## Data

```json
{
  "end_line": 58,
  "entity_kind": "class",
  "parent": "math",
  "start_line": 33,
  "symbol": "ATan2"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/functions/math.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":33,"selector":"L33-L58","symbol":"ATan2"}`

## Referenced by

None.

## Subject

[django/db/models/functions/math::ATan2](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 58,
    "entity_kind": "class",
    "parent": "math",
    "start_line": 33,
    "symbol": "ATan2"
  },
  "id": "18363d27-8239-4845-81b5-10142bbf6468",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:01.6724110+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 33,
        "selector": "L33-L58",
        "symbol": "ATan2"
      },
      "rel": "derived_from",
      "target": "django/db/models/functions/math.py"
    }
  ],
  "status": "live",
  "subject_id": "a1f704be-70b6-4074-8f2c-988054e68886",
  "subject_name": "django/db/models/functions/math::ATan2",
  "tags": [
    "entity:class"
  ],
  "text": "class ATan2(NumericOutputFieldMixin, Func)"
}
```
