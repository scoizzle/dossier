# Fact f22d90eb

Store id: 700310d2-5fdd-4172-a10f-84faf3396fd9

## Text

```text
def _check_max_length_attribute(self, **kwargs)
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
- posted_at: `2026-11-09T22:39:42.3773100+00:00`

## Data

```json
{
  "end_line": 1296,
  "entity_kind": "method",
  "parent": "CharField",
  "start_line": 1268,
  "symbol": "CharField._check_max_length_attribute"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1268,"selector":"L1268-L1296","symbol":"CharField._check_max_length_attribute"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::CharField._check_max_length_attribute](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1296,
    "entity_kind": "method",
    "parent": "CharField",
    "start_line": 1268,
    "symbol": "CharField._check_max_length_attribute"
  },
  "id": "700310d2-5fdd-4172-a10f-84faf3396fd9",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:42.3773100+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1268,
        "selector": "L1268-L1296",
        "symbol": "CharField._check_max_length_attribute"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "df8245fc-d853-4cfa-9731-4bf0bc3a93fb",
  "subject_name": "django/db/models/fields/__init__::CharField._check_max_length_attribute",
  "tags": [
    "entity:method"
  ],
  "text": "def _check_max_length_attribute(self, **kwargs)"
}
```
