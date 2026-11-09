# Fact 92302f7d

Store id: 089f878f-1a03-4887-bd31-454f73855610

## Text

```text
def get_col(self, alias, output_field=None)
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
- posted_at: `2026-11-09T22:39:43.0134310+00:00`

## Data

```json
{
  "end_line": 116,
  "entity_kind": "method",
  "parent": "CompositePrimaryKey",
  "start_line": 110,
  "symbol": "CompositePrimaryKey.get_col"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/composite.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":110,"selector":"L110-L116","symbol":"CompositePrimaryKey.get_col"}`

## Referenced by

None.

## Subject

[django/db/models/fields/composite::CompositePrimaryKey.get_col](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 116,
    "entity_kind": "method",
    "parent": "CompositePrimaryKey",
    "start_line": 110,
    "symbol": "CompositePrimaryKey.get_col"
  },
  "id": "089f878f-1a03-4887-bd31-454f73855610",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:43.0134310+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 110,
        "selector": "L110-L116",
        "symbol": "CompositePrimaryKey.get_col"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/composite.py"
    }
  ],
  "status": "live",
  "subject_id": "c3f3062c-6efa-49aa-8396-4dd1d3d3f786",
  "subject_name": "django/db/models/fields/composite::CompositePrimaryKey.get_col",
  "tags": [
    "entity:method"
  ],
  "text": "def get_col(self, alias, output_field=None)"
}
```
