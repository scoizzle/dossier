# Fact 8fd43a16

Store id: adbd29bd-5a49-4e58-8ebb-9bea80cbdf70

## Text

```text
def clone(self)
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
- posted_at: `2026-11-09T23:32:07.6214740+00:00`

## Data

```json
{
  "end_line": 223,
  "entity_kind": "method",
  "parent": "WhereNode",
  "start_line": 217,
  "symbol": "WhereNode.clone"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/sql/where.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":217,"selector":"L217-L223","symbol":"WhereNode.clone"}`

## Referenced by

None.

## Subject

[django/db/models/sql/where::WhereNode.clone](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 223,
    "entity_kind": "method",
    "parent": "WhereNode",
    "start_line": 217,
    "symbol": "WhereNode.clone"
  },
  "id": "adbd29bd-5a49-4e58-8ebb-9bea80cbdf70",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:07.6214740+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 217,
        "selector": "L217-L223",
        "symbol": "WhereNode.clone"
      },
      "rel": "derived_from",
      "target": "django/db/models/sql/where.py"
    }
  ],
  "status": "live",
  "subject_id": "2aca92cb-a5c4-4e23-ad08-93a2dec92a89",
  "subject_name": "django/db/models/sql/where::WhereNode.clone",
  "tags": [
    "entity:method"
  ],
  "text": "def clone(self)"
}
```
