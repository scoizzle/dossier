# Fact 0d0a7309

Store id: 5bc1dffb-eddd-4946-a7bc-612a006b6a75

## Text

```text
def _empty(of_cls)
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
- posted_at: `2026-11-09T23:31:56.4089350+00:00`

## Data

```json
{
  "end_line": 120,
  "entity_kind": "function",
  "parent": "__init__",
  "start_line": 117,
  "symbol": "_empty"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":117,"selector":"L117-L120","symbol":"_empty"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::_empty](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 120,
    "entity_kind": "function",
    "parent": "__init__",
    "start_line": 117,
    "symbol": "_empty"
  },
  "id": "5bc1dffb-eddd-4946-a7bc-612a006b6a75",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:56.4089350+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 117,
        "selector": "L117-L120",
        "symbol": "_empty"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "44c6a437-037c-4693-896f-4da6eda54377",
  "subject_name": "django/db/models/fields/__init__::_empty",
  "tags": [
    "entity:function"
  ],
  "text": "def _empty(of_cls)"
}
```
