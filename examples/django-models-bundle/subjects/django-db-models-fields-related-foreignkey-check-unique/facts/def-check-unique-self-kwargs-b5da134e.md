# Fact b5da134e

Store id: ba329a84-523f-4091-98b9-b22b8ef177af

## Text

```text
def _check_unique(self, **kwargs)
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
- posted_at: `2026-11-09T23:31:58.7510400+00:00`

## Data

```json
{
  "end_line": 1186,
  "entity_kind": "method",
  "parent": "ForeignKey",
  "start_line": 1170,
  "symbol": "ForeignKey._check_unique"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/related.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1170,"selector":"L1170-L1186","symbol":"ForeignKey._check_unique"}`

## Referenced by

None.

## Subject

[django/db/models/fields/related::ForeignKey._check_unique](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1186,
    "entity_kind": "method",
    "parent": "ForeignKey",
    "start_line": 1170,
    "symbol": "ForeignKey._check_unique"
  },
  "id": "ba329a84-523f-4091-98b9-b22b8ef177af",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:58.7510400+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1170,
        "selector": "L1170-L1186",
        "symbol": "ForeignKey._check_unique"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/related.py"
    }
  ],
  "status": "live",
  "subject_id": "2ced025e-a350-4cf7-b04c-2d9b6a9252ef",
  "subject_name": "django/db/models/fields/related::ForeignKey._check_unique",
  "tags": [
    "entity:method"
  ],
  "text": "def _check_unique(self, **kwargs)"
}
```
