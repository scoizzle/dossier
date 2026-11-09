# Fact e80a688e

Store id: ae641ad3-b913-42ad-a57d-4591ca4b635a

## Text

```text
def _get_naive_now()
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
- posted_at: `2026-11-09T23:31:56.5659900+00:00`

## Data

```json
{
  "end_line": 1388,
  "entity_kind": "function",
  "parent": "__init__",
  "start_line": 1387,
  "symbol": "_get_naive_now"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1387,"selector":"L1387-L1388","symbol":"_get_naive_now"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::_get_naive_now](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1388,
    "entity_kind": "function",
    "parent": "__init__",
    "start_line": 1387,
    "symbol": "_get_naive_now"
  },
  "id": "ae641ad3-b913-42ad-a57d-4591ca4b635a",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:56.5659900+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1387,
        "selector": "L1387-L1388",
        "symbol": "_get_naive_now"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "f604c656-bdb3-4c4a-af07-c5e42b5bc07a",
  "subject_name": "django/db/models/fields/__init__::_get_naive_now",
  "tags": [
    "entity:function"
  ],
  "text": "def _get_naive_now()"
}
```
