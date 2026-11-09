# Fact c9e61065

Store id: e70d7a66-4be9-4e45-9a13-19ca651d5aa4

## Text

```text
def check(self, **kwargs)
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
- posted_at: `2026-11-09T23:44:50.0796640+00:00`

## Data

```json
{
  "end_line": 1397,
  "entity_kind": "method",
  "parent": "DateTimeCheckMixin",
  "start_line": 1392,
  "symbol": "DateTimeCheckMixin.check"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1392,"selector":"L1392-L1397","symbol":"DateTimeCheckMixin.check"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::DateTimeCheckMixin.check](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1397,
    "entity_kind": "method",
    "parent": "DateTimeCheckMixin",
    "start_line": 1392,
    "symbol": "DateTimeCheckMixin.check"
  },
  "id": "e70d7a66-4be9-4e45-9a13-19ca651d5aa4",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:50.0796640+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1392,
        "selector": "L1392-L1397",
        "symbol": "DateTimeCheckMixin.check"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "3297131f-3ea5-444f-935f-4866655bdca5",
  "subject_name": "django/db/models/fields/__init__::DateTimeCheckMixin.check",
  "tags": [
    "entity:method"
  ],
  "text": "def check(self, **kwargs)"
}
```
