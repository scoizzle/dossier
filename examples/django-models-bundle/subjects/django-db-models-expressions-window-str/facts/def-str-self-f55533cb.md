# Fact f55533cb

Store id: 6d14d176-419c-4469-9d1a-27c97bf0182e

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
- posted_at: `2026-11-09T23:44:49.6746990+00:00`

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
  "id": "6d14d176-419c-4469-9d1a-27c97bf0182e",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:49.6746990+00:00"
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
  "subject_id": "f0cb2aa8-588c-4beb-a2ae-c97f2e6c4ff6",
  "subject_name": "django/db/models/expressions::Window.__str__",
  "tags": [
    "entity:method"
  ],
  "text": "def __str__(self)"
}
```
