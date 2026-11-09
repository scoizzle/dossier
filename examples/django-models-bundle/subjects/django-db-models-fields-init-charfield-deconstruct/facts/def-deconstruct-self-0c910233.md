# Fact 0c910233

Store id: 684d531b-6cd8-4fea-8b81-f2acc33e0df2

## Text

```text
def deconstruct(self)
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
- posted_at: `2026-11-09T22:39:42.3910180+00:00`

## Data

```json
{
  "end_line": 1357,
  "entity_kind": "method",
  "parent": "CharField",
  "start_line": 1353,
  "symbol": "CharField.deconstruct"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1353,"selector":"L1353-L1357","symbol":"CharField.deconstruct"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::CharField.deconstruct](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1357,
    "entity_kind": "method",
    "parent": "CharField",
    "start_line": 1353,
    "symbol": "CharField.deconstruct"
  },
  "id": "684d531b-6cd8-4fea-8b81-f2acc33e0df2",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:42.3910180+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1353,
        "selector": "L1353-L1357",
        "symbol": "CharField.deconstruct"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "ecd0348e-62d5-4dd4-897b-d6e98dacae13",
  "subject_name": "django/db/models/fields/__init__::CharField.deconstruct",
  "tags": [
    "entity:method"
  ],
  "text": "def deconstruct(self)"
}
```
