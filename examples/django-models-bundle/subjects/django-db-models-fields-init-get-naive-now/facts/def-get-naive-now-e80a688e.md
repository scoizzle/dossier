# Fact e80a688e

Store id: 6a0920d0-c8ac-49ae-9836-8cb2a68b5adb

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
- posted_at: `2026-11-09T22:39:42.3991590+00:00`

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
  "id": "6a0920d0-c8ac-49ae-9836-8cb2a68b5adb",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:42.3991590+00:00"
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
  "subject_id": "f5f50baa-5311-4afe-bf96-8b81fb36adaf",
  "subject_name": "django/db/models/fields/__init__::_get_naive_now",
  "tags": [
    "entity:function"
  ],
  "text": "def _get_naive_now()"
}
```
