# Fact dd35b3b0

Store id: ac67896a-3a51-4ff8-9c4b-2b21432fc6fe

## Text

```text
def get_external_cols(self)
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
- posted_at: `2026-11-09T22:39:41.7288130+00:00`

## Data

```json
{
  "end_line": 1871,
  "entity_kind": "method",
  "parent": "Subquery",
  "start_line": 1870,
  "symbol": "Subquery.get_external_cols"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1870,"selector":"L1870-L1871","symbol":"Subquery.get_external_cols"}`

## Referenced by

None.

## Subject

[django/db/models/expressions::Subquery.get_external_cols](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1871,
    "entity_kind": "method",
    "parent": "Subquery",
    "start_line": 1870,
    "symbol": "Subquery.get_external_cols"
  },
  "id": "ac67896a-3a51-4ff8-9c4b-2b21432fc6fe",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:41.7288130+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1870,
        "selector": "L1870-L1871",
        "symbol": "Subquery.get_external_cols"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "66f00fba-492d-4a1b-ad14-13f523c16bbe",
  "subject_name": "django/db/models/expressions::Subquery.get_external_cols",
  "tags": [
    "entity:method"
  ],
  "text": "def get_external_cols(self)"
}
```
