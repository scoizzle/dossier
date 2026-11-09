# Fact f55533cb

Store id: 1228c5d1-3989-4c6d-9de3-2b98c42e6bf6

## Text

```text
def __str__(self)
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
- posted_at: `2026-11-09T23:31:56.0071490+00:00`

## Data

```json
{
  "end_line": 2113,
  "entity_kind": "method",
  "parent": "Window",
  "start_line": 2107,
  "symbol": "Window.__str__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2107,"selector":"L2107-L2113","symbol":"Window.__str__"}`

## Referenced by

None.

## Subject

[django/db/models/expressions::Window.__str__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2113,
    "entity_kind": "method",
    "parent": "Window",
    "start_line": 2107,
    "symbol": "Window.__str__"
  },
  "id": "1228c5d1-3989-4c6d-9de3-2b98c42e6bf6",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:56.0071490+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2107,
        "selector": "L2107-L2113",
        "symbol": "Window.__str__"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "f38d959b-a0dc-414b-b367-1e23e64efd41",
  "subject_name": "django/db/models/expressions::Window.__str__",
  "tags": [
    "entity:method"
  ],
  "text": "def __str__(self)"
}
```
