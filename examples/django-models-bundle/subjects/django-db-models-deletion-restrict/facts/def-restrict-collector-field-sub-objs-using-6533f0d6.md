# Fact 6533f0d6

Store id: aff44b35-ac0d-4e5e-ab08-e1a4272b5006

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
- posted_at: `2026-11-09T23:44:48.8996710+00:00`

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
  "id": "aff44b35-ac0d-4e5e-ab08-e1a4272b5006",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:48.8996710+00:00"
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
  "subject_id": "fbdef160-cd65-4b4e-a758-2d56c1701818",
  "subject_name": "django/db/models/deletion::RESTRICT",
  "tags": [
    "entity:function"
  ],
  "text": "def RESTRICT(collector, field, sub_objs, using)"
}
```
