# Fact 0e990c7b

Store id: 7f06edb7-896f-4928-965a-dd7039c58799

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
- posted_at: `2026-11-09T22:39:44.4470830+00:00`

## Data

```json
{
  "end_line": 1545,
  "entity_kind": "method",
  "parent": "ManyToManyField",
  "start_line": 1537,
  "symbol": "ManyToManyField.check"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/related.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1537,"selector":"L1537-L1545","symbol":"ManyToManyField.check"}`

## Referenced by

None.

## Subject

[django/db/models/fields/related::ManyToManyField.check](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1545,
    "entity_kind": "method",
    "parent": "ManyToManyField",
    "start_line": 1537,
    "symbol": "ManyToManyField.check"
  },
  "id": "7f06edb7-896f-4928-965a-dd7039c58799",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:44.4470830+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1537,
        "selector": "L1537-L1545",
        "symbol": "ManyToManyField.check"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/related.py"
    }
  ],
  "status": "live",
  "subject_id": "5ecd6126-6f67-46a8-899f-b46d77373d49",
  "subject_name": "django/db/models/fields/related::ManyToManyField.check",
  "tags": [
    "entity:method"
  ],
  "text": "def check(self, **kwargs)"
}
```
