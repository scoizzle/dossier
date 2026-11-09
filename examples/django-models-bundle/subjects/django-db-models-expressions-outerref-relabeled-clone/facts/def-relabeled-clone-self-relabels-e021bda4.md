# Fact e021bda4

Store id: 19d02f7b-ea03-4139-ae13-8a2e348cd550

## Text

```text
def relabeled_clone(self, relabels)
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
- posted_at: `2026-11-09T23:31:55.8469960+00:00`

## Data

```json
{
  "end_line": 993,
  "entity_kind": "method",
  "parent": "OuterRef",
  "start_line": 992,
  "symbol": "OuterRef.relabeled_clone"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":992,"selector":"L992-L993","symbol":"OuterRef.relabeled_clone"}`

## Referenced by

None.

## Subject

[django/db/models/expressions::OuterRef.relabeled_clone](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 993,
    "entity_kind": "method",
    "parent": "OuterRef",
    "start_line": 992,
    "symbol": "OuterRef.relabeled_clone"
  },
  "id": "19d02f7b-ea03-4139-ae13-8a2e348cd550",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:55.8469960+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 992,
        "selector": "L992-L993",
        "symbol": "OuterRef.relabeled_clone"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "9cf02108-94e2-4e64-b88c-0202d1ad9900",
  "subject_name": "django/db/models/expressions::OuterRef.relabeled_clone",
  "tags": [
    "entity:method"
  ],
  "text": "def relabeled_clone(self, relabels)"
}
```
