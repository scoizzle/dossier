# Fact c9e61065

Store id: cba0fc5b-66c6-483e-9bce-c31abc47f540

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
- posted_at: `2026-11-09T22:39:42.4027310+00:00`

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
  "id": "cba0fc5b-66c6-483e-9bce-c31abc47f540",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:42.4027310+00:00"
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
  "subject_id": "b375d64e-48e0-4fcc-8487-3ec170bb5791",
  "subject_name": "django/db/models/fields/__init__::DateTimeCheckMixin.check",
  "tags": [
    "entity:method"
  ],
  "text": "def check(self, **kwargs)"
}
```
