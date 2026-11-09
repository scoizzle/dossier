# Fact 57f55aaa

Store id: 8ecf5ff7-d55a-4282-90ac-46762065e2c3

## Text

```text
def _to_naive(value)
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
- posted_at: `2026-11-09T23:31:56.5649030+00:00`

## Data

```json
{
  "end_line": 1384,
  "entity_kind": "function",
  "parent": "__init__",
  "start_line": 1381,
  "symbol": "_to_naive"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1381,"selector":"L1381-L1384","symbol":"_to_naive"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::_to_naive](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1384,
    "entity_kind": "function",
    "parent": "__init__",
    "start_line": 1381,
    "symbol": "_to_naive"
  },
  "id": "8ecf5ff7-d55a-4282-90ac-46762065e2c3",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:56.5649030+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1381,
        "selector": "L1381-L1384",
        "symbol": "_to_naive"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "bd18f222-4b2f-4a06-b30d-9c12a0098527",
  "subject_name": "django/db/models/fields/__init__::_to_naive",
  "tags": [
    "entity:function"
  ],
  "text": "def _to_naive(value)"
}
```
