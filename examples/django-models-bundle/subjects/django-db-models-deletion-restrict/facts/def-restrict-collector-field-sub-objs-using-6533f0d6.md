# Fact 6533f0d6

Store id: e7d25852-dc70-4995-9abb-d212d7735c70

## Text

```text
def RESTRICT(collector, field, sub_objs, using)
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
- posted_at: `2026-11-09T22:39:40.9981280+00:00`

## Data

```json
{
  "end_line": 49,
  "entity_kind": "function",
  "parent": "deletion",
  "start_line": 47,
  "symbol": "RESTRICT"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/deletion.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":47,"selector":"L47-L49","symbol":"RESTRICT"}`

## Referenced by

None.

## Subject

[django/db/models/deletion::RESTRICT](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 49,
    "entity_kind": "function",
    "parent": "deletion",
    "start_line": 47,
    "symbol": "RESTRICT"
  },
  "id": "e7d25852-dc70-4995-9abb-d212d7735c70",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:40.9981280+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 47,
        "selector": "L47-L49",
        "symbol": "RESTRICT"
      },
      "rel": "derived_from",
      "target": "django/db/models/deletion.py"
    }
  ],
  "status": "live",
  "subject_id": "30c533f6-3e40-459a-8560-f64c4d8220e9",
  "subject_name": "django/db/models/deletion::RESTRICT",
  "tags": [
    "entity:function"
  ],
  "text": "def RESTRICT(collector, field, sub_objs, using)"
}
```
