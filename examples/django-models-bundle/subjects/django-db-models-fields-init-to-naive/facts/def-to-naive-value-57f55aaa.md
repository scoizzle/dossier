# Fact 57f55aaa

Store id: 3d5ebcc2-cc14-4ff0-ad0f-5d19a054f9ac

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
- posted_at: `2026-11-09T22:39:42.3971240+00:00`

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
  "id": "3d5ebcc2-cc14-4ff0-ad0f-5d19a054f9ac",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:42.3971240+00:00"
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
  "subject_id": "53cfb11c-8a1e-48a0-bc38-587fdb69963f",
  "subject_name": "django/db/models/fields/__init__::_to_naive",
  "tags": [
    "entity:function"
  ],
  "text": "def _to_naive(value)"
}
```
